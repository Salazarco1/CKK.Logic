using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
	public class Customer : Entity
	{

		private string _address;

		public string Address
		{
			get
			{
				return _address;
			}
			set
			{
				_address = value;
			}
		}
	}
}
