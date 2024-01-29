using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
	public class Customer
	{
		private int _id;
		private string _name;
		private string _address;

		public int GetId() // gets ID
		{
			return _id;
		}
		public void SetId(int id) // sets ID
		{
			_id = id;
		}
		public string GetName() // gets name
		{
			return _name;
		}
		public void SetName(string name) // sets name
		{
			_name = name;
		}
		public string GetAddress() // gets address
		{
			return _address;
		}
		public void SetAddress(string address) // sets address
		{
			_address = address;
		}
	}
}
