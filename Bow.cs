using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillyFinagler;

public enum Bow
{
	[Named("")]
	None,
	BlackBow,
	BlueBow,
	PinkBow,
	[Named("Cool Bow")]
	CoolBow,
	[Named("Fresh Bow")]
	FreshBow,
	[Named("Pretty Bow")]
	PrettyBow,
}
