using System.Text.Json;

namespace FillyFinagler
{
	public partial class Form1 : Form
	{
		private RegistryFolder registryFolder;
		private Save currentSave;

		private Dictionary<string, List<string>> locations;

		private void UnlocksToElements(ListView listView)
		{
			foreach (ListViewItem item in listView.Items)
			{
				item.Checked = currentSave.Unlocks?.Contains(item.Text) ?? false;
			}
		}

		private void UnlocksToElements()
		{
			UnlocksToElements(lvGold);
			UnlocksToElements(lvGems);
			UnlocksToElements(lvMisc);
		}

		private void SaveToElements()
		{
			currentSave = tabControl1.SelectedIndex switch
			{
				0 => registryFolder.Save1,
				1 => registryFolder.Save2,
				2 => registryFolder.Save3,
				_ => throw new Exception("Invalid tab index")
			} ?? new();
			gameMode.Value = currentSave.gameMode;
			stage.Text = currentSave.stage;
			entrance.Text = currentSave.entrance;
			experience.Value = currentSave.experience;
			difficulty.Value = currentSave.difficulty;
			UnlocksToElements();
			head.Text = currentSave.head;
			legs.Text = currentSave.legs?.ToString() ?? "";
			color.Value = currentSave.color;
		}

		private void FolderToElements()
		{
			extras.Checked = registryFolder.Extras;
			SaveToElements();
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			locations = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(File.ReadAllText("locations.json"));
			foreach (var kvp in locations)
			{
				stageDropdown.Items.Add(kvp.Key);
			}

			foreach (var f in typeof(Unlocks).GetFields())
			{
				var named = f.Name;
				foreach (var a in f.GetCustomAttributes(false))
				{
					if (a is NamedAttribute na)
					{
						named = na.Name;
					}
				}

				ListViewItem item = new() { Text = named, };
				foreach (var a in f.GetCustomAttributes(false))
				{
					switch (a)
					{
						case var t when t is Unlocks.GoldAttribute:
							lvGold.Items.Add(item);
							break;
						case var t when t is Unlocks.GemAttribute:
							lvGems.Items.Add(item);
							break;
						case var t when t is Unlocks.MiscCollectedAttribute:
							lvMisc.Items.Add(item);
							break;
					}
				}
				if (named.Contains("Socks"))
				{
					legsDropdown.Items.Add(named);
				}
			}

			registryFolder = new();
			registryFolder.ReadFromRegistry();

			FolderToElements();
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			SaveToElements();
		}

		private void lblGems_Click(object sender, EventArgs e)
		{

		}

		private void stageDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
			stage.Text = stageDropdown.SelectedItem?.ToString() ?? "";
			entrance.Text = "";
			entranceDropdown.Items.Clear();
			if (locations.ContainsKey(stage.Text))
			{
				entranceDropdown.Items.AddRange(locations[stage.Text].ToArray());
				entrance.Text = entranceDropdown.Items[0].ToString();
			}

			stageDropdown.Text = entranceDropdown.Text = "";
		}

		private void entranceDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
			entrance.Text = entranceDropdown.SelectedItem?.ToString() ?? "";
			entranceDropdown.Text = "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			registryFolder.ReadFromRegistry();
			FolderToElements();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			currentSave.gameMode = (int)gameMode.Value;
			currentSave.stage = stage.Text;
			currentSave.entrance = entrance.Text;
			currentSave.experience = (int)experience.Value;
			currentSave.difficulty = (int)difficulty.Value;
			currentSave.Unlocks = new();
			foreach (ListViewItem item in lvGold.Items)
			{
				if (item.Checked)
				{
					currentSave.Unlocks.Add(item.Text);
					currentSave.Unlocks.Add(item.Text + "Collected");
				}
			}
			foreach (ListViewItem item in lvGems.Items)
			{
				if (item.Checked)
				{
					currentSave.Unlocks.Add(item.Text);
				}
			}
			foreach (ListViewItem item in lvMisc.Items)
			{
				if (item.Checked)
				{
					currentSave.Unlocks.Add(item.Text);
					currentSave.Unlocks.Add(item.Text + "Collected");
				}
			}

			registryFolder.WriteSave(currentSave, tabControl1.SelectedIndex);
		}
	}
}
