﻿namespace PhotoSchool.ViewModels.Settings
{
    using PhotoSchool.Models;
    using PhotoSchool.Models.Enumerations;
    using PhotoSchool.Web.Infrastructure.Mapping;
    using System.Collections.Generic;

    public class SettingViewModel : IMapFrom<CameraSetting>
    {
        public int Id { get; set; }

        public SettingType SettingType { get; set; }

        public string ShortDescription { get; set; }

        public string Explanation { get; set; }

        public string ImageUrl { get; set; }
    }
}