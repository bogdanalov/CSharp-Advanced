﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_08.Military_Force.Models.Interfaces
{
	interface IRepair
	{
		string PartName { get; }
		int HoursWorked { get; }
	}
}
