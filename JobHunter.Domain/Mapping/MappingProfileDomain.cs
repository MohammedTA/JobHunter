using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using JobHunter.Data.Entities;
using JobHunter.Domain.Dto;
using Microsoft.AspNetCore.Identity;

namespace JobHunter.Domain.Mapping
{
     public static class MappingExpressionExtensions
     {
         public static IMappingExpression<TSource, TDest> IgnoreAllUnmapped<TSource, TDest>(this IMappingExpression<TSource, TDest> expression)
         {
             expression.ForAllMembers(opt => opt.Ignore());
             return expression;
         }
     }
    public class MappingProfileDomain : Profile
    {
         public MappingProfileDomain()
         {
             CreateMap<AppUser, IdentityUser>();
             CreateMap<UserForRegisterDto, AppUser>();
             CreateMap<AppUser, UserForReturnDto>()
                 .IgnoreAllUnmapped()
                 .ForMember(u => u.Email, opt => opt.MapFrom(app => app.Email))
                 .ForMember(u => u.IsEmployer, opt => opt.MapFrom(app => app.IsEmployer));
         }
    }
}
