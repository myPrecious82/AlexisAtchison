using System;
using System.Collections.Generic;
using System.Linq;
using AlexisAtchison.Data;
using AlexisAtchison.Interfaces;
using AlexisAtchison.Models;

namespace AlexisAtchison.Repositories
{
    public class AppRepository : IAppRepository
    {
        private readonly MyContext _context;
        public static List<Lead> Leads = new List<Lead>();

        public AppRepository(MyContext context)
        {
            _context = context;
        }

        public override IEnumerable<Lead> GetAllLeads()
        {
            throw new System.NotImplementedException();
        }

        public override Lead GetLeadById(int id)
        {
            throw new System.NotImplementedException();
        }

        public override int DeleteLead(Lead lead)
        {
            throw new System.NotImplementedException();
        }

        public override Lead SaveLead(Lead lead)
        {
            Leads.Add(lead);

            return lead;
        }

        public override List<PropertyListing> GetAllPropertyListings()
        {
            return PropertyListings.ToList();
        }

        public override PropertyListing GetPropertyListingById(int id)
        {
            throw new System.NotImplementedException();
        }

        public override PropertyListing GetPropertyListingByTitle(string title)
        {
            throw new System.NotImplementedException();
        }

        public override IEnumerable<PropertyListing> GetPropertyListingsByZip(int zip)
        {
            throw new NotImplementedException();
        }

        public override int DeleteProperty(PropertyListing prop)
        {
            throw new System.NotImplementedException();
        }

        public override PropertyListing SavePropertyListing(PropertyListing prop)
        {
            throw new System.NotImplementedException();
        }

        private static readonly IEnumerable<PropertyListing> PropertyListings = new List<PropertyListing>
        {
            new PropertyListing { Id = 0, Title = "Manderley",
                SalePrice = 1563500, Zip = 62704, NumBedrooms = 23 },
            new PropertyListing { Id = 1, Title = "Gryffindor",
                SalePrice = 2654900, Zip = 62711, NumBedrooms = 45 },
            new PropertyListing { Id = 2, Title = "Misselthwaite Manor",
                SalePrice = 5648400, Zip = 62703, NumBedrooms = 54 },
            new PropertyListing { Id = 3, Title = "Satis House",
                SalePrice = 2659400, Zip = 62701, NumBedrooms = 21 },
            new PropertyListing { Id = 4, Title = "Slytherin",
                SalePrice = 4236600, Zip = 62711, NumBedrooms = 64 },
            new PropertyListing { Id = 5, Title = "Barton Cottage",
                SalePrice = 1568400, Zip = 62703, NumBedrooms = 19 },
            new PropertyListing { Id = 6, Title = "Ravenclaw",
                SalePrice = 3547000, Zip = 62711, NumBedrooms = 75 },
            new PropertyListing { Id = 7, Title = "Thornfield Hall",
                SalePrice = 4236800, Zip = 62703, NumBedrooms = 24 },
            new PropertyListing { Id = 8, Title = "221B Baker Street",
                SalePrice = 1274400, Zip = 62701, NumBedrooms = 6 },
            new PropertyListing { Id = 9, Title = "Hufflepuff",
                SalePrice = 5931500, Zip = 62711, NumBedrooms = 63 }
        };
    }
}
