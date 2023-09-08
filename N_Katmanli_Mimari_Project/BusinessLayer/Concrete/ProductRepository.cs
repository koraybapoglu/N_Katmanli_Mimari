using BusinessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ProductRepository:GenericRepository<Product>
	{
		//BURAYA TEMEL CRUD İŞLEMLERİ HARİÇ PRODUCT ENTİTY'SİNDE YAPMAK İSTEDİĞİMİZ EK VERİTABANI İŞLEMLERİNİ YAZIYORUZ.
	}
}
