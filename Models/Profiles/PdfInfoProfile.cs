﻿using System.Linq;
using AutoMapper;
using Models.Models;
using Models.RawModels;

namespace Models.Profiles
{
    public class PdfInfoProfile: Profile
    {
        public PdfInfoProfile()
        {
            CreateMap<RawPdfInfo, PdfInfo>();
            CreateMap<PdfInfo, RawPdfInfo>();
        }
    }
}