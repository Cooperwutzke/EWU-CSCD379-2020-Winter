﻿using AutoMapper;
using BlogEngine.Data;
using System.Reflection;

namespace BlogEngine.Business
{
    public class AutomapperProfileConfiguration : Profile
    {
        public AutomapperProfileConfiguration()
        {
            CreateMap<Author, Dto.Author>();
            CreateMap<Dto.AuthorInput, Author>();

            CreateMap<Post, Dto.Post>();
            CreateMap<Dto.PostInput, Post>();

            CreateMap<Author, Author>().ForMember(property => property.Id, option => option.Ignore());
            CreateMap<Tag, Tag>().ForMember(property => property.Id, option => option.Ignore());
        }

        public static IMapper CreateMapper()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(Assembly.GetExecutingAssembly());
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}
