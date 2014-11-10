﻿namespace PhotoSchool.Web.Controllers
{
    using System.Web.Mvc;
    using System.Linq;
    using PhotoSchool.Data;
    using PhotoSchool.Data.Contracts.Repository;
    using PhotoSchool.Models;
    using PhotoSchool.Data.Repositories.Base;
    using System;
    using PhotoSchool.ViewModels.Glosary;
    using AutoMapper.QueryableExtensions;
    using PhotoSchool.Controllers;

    public class GlosaryController : BaseController
    {
        private const int PageSize = 2;

        public GlosaryController(IPhotoSchoolData data)
            : base(data)
        {
        }

        public ActionResult AllWords(int? id)
        {
            int pageNumber = id.GetValueOrDefault(1);
            var allWords = this.Data.Words.All().OrderBy(x => x.Name);

            var articles = allWords.Skip((pageNumber - 1) * PageSize).Take(PageSize);
            ViewBag.Pages = Math.Ceiling((double)allWords.Count() / PageSize);
            return View(allWords);
        }
    }
}