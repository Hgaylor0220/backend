using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CapStoneCSharp.Models
{
    public class CapStoneCSharpContext : IdentityDbContext<ApplicationUser>
    {
        
        public CapStoneCSharpContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<Favorite> Favorites { get; set; }
        public DbSet<River> River { get; set; }
        public DbSet<FavoriteRiver> FavoriteRiver { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<River>()
                .HasData(
                    new River { RiverId = 1, RiverName = "Clackamas, upper", Description =" Great class three plus rapids with pool drops that are spread out through the run making it possible  to put in and take out when ever. This run is great for kayakers, IK, rafting and paddle boards", Class ="III-IV", RunLength = "21.8 Miles", PutIn = "Powerhouse, Hole in the wall, Fish Creek, Toilet bowl", TakeOut = "Toilet Bowl, Moore Creek, Memoloose", Location = "Estacada, Oregon", StationNumber= 14209500 },

                    new River { RiverId = 2, RiverName = "Clackamas, lower", Description = "Long run with fun class two rapids perfect for beginers and floaters. The rapids are short with pool drops. Depending on flow, has some great play features", Class = "II", RunLength = "21.8 Miles", PutIn = "Mciver(upper and lower park area), Feldheimer, Barton , Carver", TakeOut = " Feldheimer, Barton Park , Carver Park, Clackamette park", Location = "Estacada, Oregon", StationNumber= 14210000 },

                    new River { RiverId = 3, RiverName = "North Santiam", Description = "This run can be split up into three runs. The rapids range from class II-V. The upper section, big cliff dam to packsaddle are considered class III-V, packsaddle down to Mill City falls(very small waterfall) for class II-III and Mill City to Mehama for class II on.", Class = "II-V", RunLength = "21.2 miles", PutIn = "Big Cliff Dam, Pack Saddle, Mill City, Mehama", TakeOut = "Pack Saddle, Mill City, Mehama", Location ="Mill City, Oregon", StationNumber= 14178000 },

                    new River { RiverId = 4, RiverName = "Mckenzie", Description = "Beautiful river with class two rapids and pool drops. Great for beginners. This run is normally split into three differnent sections. Olallie Campground to Paradise Campground,  Paradise to Finn Rock and inn Rock to Leaburg Dam.", Class = "II-III", RunLength = "", PutIn = " Finn Rock, Ollalie Campground,Paradise Campground  ", TakeOut = "Finn Rock, Paradise Campground ,Prince Helfrich Landing" , Location = "Eugene, Oregon", StationNumber= 14162500 },

                    new River { RiverId = 5, RiverName = "Deschutes", Description = "Day trip, Multiday or just a run. Deschutes has it all. The river has over 15 different runs ranging from class I-V for all different skill levels.The rapids are ranging from continuos wave trains to pool drop excitement. If the water doesnt take your breath away the scienery will. You can do commercial runs and private runs on this river. Good for rafting, kayaking, IK and more!  ", Class = "III", RunLength = "52.4 miles", PutIn = "Warm Springs", TakeOut = "Sandy Beach" , Location = "Bend, Oregon", StationNumber= 14103000},

                    new River { RiverId = 6, RiverName = "John Day", Description = "Looking for a great family adventure? the John day river might be the river for you. Its a beautiful river surrounded by canyons. This normally is a three day trip down with rapids ranging from class II- III", Class = "II-III", RunLength = "69 Miles", PutIn = "Bridge in Clarno where Oregon 218 crosses the river.", TakeOut = "Cooton wood bridge where Oregon 206 crosses the river", Location = "Spray, Oregon", StationNumber= 14038530 },

                    new River { RiverId = 7, RiverName = "Sandy", Description = "Beautiful foresty run, with no raods on the side, so if you are in need of walking out it could be an adventure! The rapids are followed by a nice pool drop at the end making this a great run to have some fun", Class = "II -III", RunLength = "6.8 miles", PutIn = "Dodge Park", TakeOut = "Oxbow Park", Location = "Sandy, Oregon", StationNumber= 14142500 },

                    new River { RiverId = 8, RiverName = "Rogue River", Description = "This is a great run for skilled coateers with a lot of play boating features. Some of the rapids can be very technical, advisory scouting prior to running rapids if you have not done it before. Nugget Falls and Ti'lomikh falls can present some difficulties. Ti'lomikh must be scouted from the road prior to put in.", Class = "IV", RunLength = "4.6 miles", PutIn = "Follow Oregon 234 for a couple miles to a old gravel road, put in is below Lymans", TakeOut = "Gold Hill Sports park boat ramp", Location = "Central Point, Oregon", StationNumber= 14359000 },

                    new River { RiverId = 9, RiverName = "White Salmon", Description = "Beauftiful river that is surrounded by lavish forest and crystal blue water. This river can be run year around. There are great play boat features, waterfalls, and pool drops. This run can be enjoyed by raft, kayaking and canoes. If you want to have a stress free family trip commercial runs are permited on this run ", Class = "II- IV", RunLength = "8 miles ", PutIn = "BZ Corner, Husem Falls", TakeOut = "Husum Falls, Northwestern Park", Location = "White Salmon, Washington", StationNumber= 14123500 },

                    new River { RiverId = 10, RiverName = "Wind", Description = "If you are a advanced boater looking for some continuous technical rapids with some manditory must make moves,surround by lavish green foresty, the Upper Wind is for you. Not recommended for a class III boater. The Wind can be ran anywhere from 300-2500 cfs", Class = "IV-V", RunLength = "6 miles", PutIn = "Stabler, trout Creek", TakeOut = "From the Wind River high way turn left on to High bridge road and make your first right onto Old Detour Road. Follow the dirt road down to the river.", Location = "Carson, Washington", StationNumber= 999 },

                    new River { RiverId = 11, RiverName = "Canyon Creek", Description = "Great creek boat run with lots of waterfall features surrounded by lavish forrest. This run is a true class V, luering in all of the advance class V boaters. The river has countinuos drops with undercuts and lots of down wood. Being in a canyon the geology can change over time, changing the river features", Class = "V", RunLength = "7 miles", PutIn = "East on US 20 for 2.7 miles and turn right on NF 2032 for about 7 miles till NF 145 then turn right. Go about 7 miles to the junction of Canyon Creek and turn right. Thenfo about a mile to NF 2026 and turn left. Put in will but up a little ways on the bridge.", TakeOut = "Take US 20 past Canyon creek, turn left on spur road that will lead to the confluence of Canyon creen with the santiam River.", Location = "", StationNumber= 14219000 },

                    new River { RiverId = 12, RiverName = "Washougal", Description = "A great quick run that close to Portland and Vancouver. The river is surrounded by forest. There are beautiful bolder gardens and great play features on this river.", Class = "II-IV", RunLength = "5 miles", PutIn = "Public Fishing Road, Mile post 5 ", TakeOut = "Mile post 3 on Washougal River Road, Hathaway Park", Location = "Washougal, Washington", StationNumber= 999  },

                    new River { RiverId = 13, RiverName = "Klickitat", Description = " Klikitat is not for the faint hearted solely based on getting on the river. It can be a little difficult with the canyon drops, step ledges and rocky hills. Once on the river it is a breath taking run surroundedby canyon forrest and crystal blue water. The run can be dangerous at high flow making rescues difficult. There are alot of potential hazards to this run with down wood and continuous class three rapids", Class = "III-IV", RunLength = "11.6 miles", PutIn = "Icehouse Public Access", TakeOut = "Klikitat Salmon Hatchery", Location = "Pitt, Washington", StationNumber= 14111400 },

                    new River { RiverId = 14, RiverName = " Wynoochee", Description = "This river can range from a beautiful friendly class II to a dangerous class V. Class V sections include sieves and continous pushy rapids depending on the flows.", Class = "II-V", RunLength = "10.4 miles", PutIn = "Wynoochee Reservoir, Wynoochee dam, Fish collection Dam, FR 220 Spur ", TakeOut = "Fish collection Dam, FR 220 Spur, Save Creek", Location = "Grisdale, Washington", StationNumber= 12035400 },

                    new River { RiverId = 15, RiverName = "Ohanapecosh (ohani)", Description = "Beautiful forresty run originating in the lush growth of Mt. Rainier National Park. If you arent taken away by the beautiful landscape the crystal blue water will take your breath away. This Run is best between 700-3000CFS", Class = "V", RunLength = "8 miles", PutIn = "Ohanapecosh Campground", TakeOut = "La Wis Wis Campground", Location = "PackWood, Washington", StationNumber= 999},

                    new River { RiverId = 16, RiverName = "Lewis River", Description = "Class IV+ rapids with high waterfall drops. This is a river to cross off the list for advanced boaters", Class = "IV-V+", RunLength = "Falls", PutIn = "Above the Falls", TakeOut = "Below the falls" , Location = "Ariel, Washingington", StationNumber= 14220500 },

                    new River { RiverId = 17, RiverName = "EFL", Description = "If you are looking to run some popular waterfalls EFL is for you!. Starting off with Sunset falls which is known as one of the friendlyiest waterfalls you can run followed by continuos rapids leading into more falls. The river is surrounded by beautiful forrest along a road allowing walks out through out the run", Class = "IV", RunLength = "3.8 miles", PutIn = "Sunset Falls rec area", TakeOut = "After Horse Shoe falls on your right", Location = "Yacolt, Washington", StationNumber= 14222500 },

                    new River { RiverId = 18, RiverName = "Wilson River", Description = "This river is surrounded by forest, the rapids are described as pool drops with lots of river curves.", Class = "II- IV", RunLength = "8 miles", PutIn = "Jones Creek Campground mile post 23", TakeOut = "Mile post 15, Mile post 18", Location = "Tillamook, Oregon", StationNumber= 14301500 },

                    new River { RiverId = 19, RiverName = "Molalla (Three bears)", Description = "Beautiful foresty canyon river that has continuos rapids that trickle into each other. The river can be scouted from the road and it is recommended. Depending on the flow the river can go from some must make moves class three to a big water class four.", Class = "III-IV", RunLength = "8.3 miles", PutIn = "Turner Bridge", TakeOut = "Glen Avon Bridge", Location = "Molalla, Oredgon", StationNumber= 14200000 },

                    new River { RiverId = 20, RiverName = "Jordan Creek", Description = "Jordan creek is a beautifule narrow ruver that leads into the Wilson river, There are continuos class III rapids all the way down. If you enjoy narrow streams and technical moves this is the river for you to improve your creek boat skills. This is a river that has a couple of tricky spots always a great idea to scout out a rapid if you are not familular with the run. This is an area for active logging so alway be on guard for wood in the water.", Class = "III+", RunLength = "6.5 miles", PutIn = "Hann Bridge, which is about 5 miles up from put in. Stay on the road that follows the river right.", TakeOut = "Mile post 18, the bridge over Jordan creek. Where the Wilson river meets", Location = "Tillamook, Oregon", StationNumber= 14301500 }
                    
                );

        }


    }
}