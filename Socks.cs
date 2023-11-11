using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillyFinagler;

public enum Socks
{
	[Named("")]
	None,
	BlackSocks,
	GoldSocks,
	BlueSocks,
	[Named("Cool Socks")]
	CoolSocks,
	[Named("Cute Socks")]
	CuteSocks,
	PrettySocks,
	[Named("Pretty Socks")]
	PrettySocks2,
}
