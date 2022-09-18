using Maui_Blazor_Basics.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_Blazor_Basics.Services
{
	public class PersonDBService
	{
		private SQLiteConnection conn;
		string _dbPath;
		public string StatusMessage { get; set; }

		private void Init()
		{
			if (conn != null)
				return;

			conn = new SQLiteConnection(_dbPath);
			conn.CreateTable<PersonModel>();
		}

		public PersonDBService(string dbPath)
		{
			this._dbPath = dbPath;
		}

		public void AddNewPerson(string name)
		{
			int result = 0;
			try
			{
				Init();

				if (string.IsNullOrEmpty(name))
				{
					throw new Exception("Invalid name");
				}

				result = conn.Insert(new PersonModel {Name = name });
			} catch (Exception ex) { }
		}

		public void DeletePerson(int id)
		{
			int result = 0;
			try
			{
				Init();

				conn.Delete(conn.Get<PersonModel>(id));
			} catch (Exception ex) { }
		}

		public PersonModel GetPerson(int id)
		{
			try
			{
				Init();

				PersonModel p = conn.Get<PersonModel>(id);
				return p;
			} catch (Exception ex)
			{
				return null;
			}
		}

		public List<PersonModel> GetAllPeople()
		{
			try
			{
				Init();
				return conn.Table<PersonModel>().ToList();
			} catch (Exception ex)
			{
				StatusMessage = string.Format($"Failed to retrieve data {ex.Message}");
			}

			return new List<PersonModel>();
		}
	}
}
