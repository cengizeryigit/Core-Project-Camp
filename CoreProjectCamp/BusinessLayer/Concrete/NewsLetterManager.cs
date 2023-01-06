using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class NewsLetterManager : INewsLetterService
	{
		INesLetterDal _newsletterDal;

		public NewsLetterManager(INesLetterDal newsletterDal)
		{
			_newsletterDal = newsletterDal;
		}

		public void AddNewsLetter(NewsLetter newsletter)
		{
			_newsletterDal.Insert(newsletter);
		}
	}
}
