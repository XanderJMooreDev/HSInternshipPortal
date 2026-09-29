using InternshipPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InternshipPortal.Controllers
{
    public class InternshipListingController : Controller
    {
        List<InternshipListing> listings = new List<InternshipListing>();
        public async Task<IActionResult> GetListings()
        {
            return Ok(listings);
        }

        public async Task<IActionResult> CreateListing(InternshipListing listing)
        {
            listings.Add(listing);
            return Ok(listings);
        }
    }
}
