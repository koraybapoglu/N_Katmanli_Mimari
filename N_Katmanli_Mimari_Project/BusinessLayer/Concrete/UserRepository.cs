using BusinessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	internal class UserRepository:GenericRepository<User>
	{
		//BURAYA TEMEL CRUD İŞLEMLERİ HARİÇ KULLANICI ENTİTY'SİNDE YAPMAK İSTEDİĞİMİZ EK VERİTABANI İŞLEMLERİNİ YAZIYORUZ.
	}
}
