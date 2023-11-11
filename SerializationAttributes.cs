using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillyFinagler;

[AttributeUsage(AttributeTargets.Field)]
public class NamedAttribute : Attribute
{
	public string Name;
	public NamedAttribute(string name)
	{
		Name = name;
	}
}

[AttributeUsage(AttributeTargets.Field)]
public class TrueValueAttribute : Attribute
{
	public String Value;
	public TrueValueAttribute(string value)
	{
		Value = value;
	}
}

[AttributeUsage(AttributeTargets.Field)]
public class FalseValueAttribute : Attribute
{
	public String Value;
	public FalseValueAttribute(string value)
	{
		Value = value;
	}
}
