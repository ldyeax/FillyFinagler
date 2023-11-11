using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace FillyFinagler;

// Computer\HKEY_CURRENT_USER\Software\BitGames\Anonfilly
public class RegistryFolder
{
	const string folderPath = @"Software\BitGames\Anonfilly";
	private static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions() { IncludeFields = true };

	[Named("save_save1_h1476750443")]
	public Save Save1;
	[Named("save_save2_h1476750440")]
	public Save Save2;
	[Named("save_save3_h1476750441")]
	public Save Save3;

	public string[] SaveNames = new string[] { "save_save1_h1476750443", "save_save2_h1476750440", "save_save3_h1476750441" };

	[Named("Extras_h2358590956")]
	[TrueValueAttribute("Unlocked")]
	[FalseValueAttribute("")]
	public bool Extras;

	public void ReadFromRegistry()
	{
		using var folder = Registry.CurrentUser.OpenSubKey(folderPath);
		if (folder == null)
		{
			throw new Exception("Registry folder does not exist");
		}

		foreach (var f in typeof(RegistryFolder).GetFields(BindingFlags.Public | BindingFlags.Instance))
		{
			string trueValue = null;
			string named = f.Name;
			foreach (var a in f.GetCustomAttributes())
			{
				if (a is NamedAttribute na)
				{
					named = na.Name;
				}
				if (a is TrueValueAttribute tva)
				{
					trueValue = tva.Value;
				}
			}

			if (f.Name == nameof(Extras))
			{
				var data = (byte[])folder.GetValue(named);
				if (data == null)
				{
					Extras = false;
					continue;
				}
				var dataString = Encoding.ASCII.GetString(data, 0, data.Length - 1);
				Extras = dataString == trueValue;
				continue;
			}

			switch (f.FieldType)
			{
				case var t when t == typeof(Save):
					var data = (byte[])folder.GetValue(named);
					if (data == null)
					{
						continue;
					}
					var jsonString = Encoding.ASCII.GetString(data, 0, data.Length - 1);
					try
					{
						var save = JsonSerializer.Deserialize<Save>(jsonString, jsonSerializerOptions);
						f.SetValue(this, save);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Corrupted Save " + named + "\n" + ex.Message);
					}
					continue;
			}
		}
	}
	public void WriteSave(Save save, int zeroBasedIndex)
	{
		var jsonString = JsonSerializer.Serialize(save, jsonSerializerOptions);
		if (jsonString == null)
		{
			MessageBox.Show("Null json");
			return;
		}
		var data = Encoding.ASCII.GetBytes(jsonString);
		var dataWithTrailingZero = new byte[data.Length + 1];
		data.CopyTo(dataWithTrailingZero, 0);

		using var folder = Registry.CurrentUser.OpenSubKey(folderPath, true);
		string name = SaveNames[zeroBasedIndex];
		folder.SetValue(name, dataWithTrailingZero);
	}
}
