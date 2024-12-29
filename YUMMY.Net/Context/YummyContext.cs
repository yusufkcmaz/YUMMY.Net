using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Web;
using YUMMY.Net.Models;

namespace YUMMY.Net.Context
{
    public class YummyContext :DbContext
    {
        public DbSet<About> Abouts { get; set; } 
        public DbSet<Booking> bookings { get; set; } 
        public DbSet<Category> categories { get; set; } 
        public DbSet<Chef> Chefs { get; set; } 
        public DbSet<ChefSocial> chefSocials { get; set; } 
        public DbSet<ContactInfo> ContactInfos { get; set; } 
        public DbSet<Event> events  { get; set; } 
        public DbSet<Feature> features   { get; set; } 
        public DbSet<Message> messages    { get; set; } 
        public DbSet<PhotoGallery> photoGalleries   { get; set; } 
        public DbSet <Product> products  { get; set; } 
        public DbSet <Service> Services  { get; set; } 
        public DbSet <Testimonial> testimonials  { get; set; } 
        public DbSet <Admin> Admins  { get; set; } 
        public DbSet <SocialMedia> SocialMedias  { get; set; } 


    }
}