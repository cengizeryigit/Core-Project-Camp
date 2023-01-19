﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommentService
	{
		void AddComment(Comment comment);

		List<Comment> GetList(int id);

        List<Comment> GetCommentWithBlog();

    }
}
