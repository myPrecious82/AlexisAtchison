using System.Collections.Generic;
using AlexisAtchison.Models;

namespace AlexisAtchison.Interfaces
{
    public abstract class IAppRepository
    {
        public abstract IEnumerable<Lead> GetAllLeads();
        public abstract Lead GetLeadById(int id);
        public abstract int DeleteLead(Lead lead);
        public abstract Lead SaveLead(Lead lead);

        public abstract List<PropertyListing> GetAllPropertyListings();
        public abstract PropertyListing GetPropertyListingById(int id);
        public abstract PropertyListing GetPropertyListingByTitle(string title);
        public abstract IEnumerable<PropertyListing> GetPropertyListingsByZip(int zip);
        public abstract int DeleteProperty(PropertyListing prop);
        public abstract PropertyListing SavePropertyListing(PropertyListing prop);
    }
}