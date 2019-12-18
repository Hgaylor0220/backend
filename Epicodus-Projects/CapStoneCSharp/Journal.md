Colors used for the wireframing ap
    background: #293576
    color for concideration: #AA4DA3;
    font style: Lucida Grande

    Resources:
    - https://waterdata.usgs.gov/nwis/uv?agency_code=USGS&site_no=14220500
    - https://water.weather.gov/ahps2/hydrograph.php?wfo=pqr&gage=sndo3&view=1,1,1,1,1,1&refresh=true (potential other site to scrap)

    Information for scrapping -
    -https://help.waterdata.usgs.gov/faq/automated-retrievals#RT

    good site for how to on scraping
    https://www.freecodecamp.org/news/the-ultimate-guide-to-web-scraping-with-node-js-daa2027dcd3/

12/6 
    started working on file structor first thing. Then worked on Wireframing from 9:30-11am (docs apt from 11:30-12:30 ish) Finished the bases of wire framing, diagram and ReadMe till 6pm (Completely forget to submit project on time =( )
    worked on addition file structor and researching API in Node.js and building scrapper in Node.JS over the weekend. 
    
Check out udemy for more react with auth info. 
Check out Mongo vs Firebased for DB options.
Start seeding data on rivers with ethan



12/13

 - schedule:
    8am-10 am - Build out the home page UI
    10- 12 - Watch video on scapper and build with video. Set up google search api. 
    12-1 lunch
    1-3 finish scrapper and return info on home page[MVP Should be complete to return infomation]
    3-5 start incorrprating User loggin if you have time. 

12/9 Week

    - Watch React videos on Udemy, work with Ethan on seeding data.
    - Get ahead on any of the todo's
    
12/16 week start

    Monday- If everything from Fri works, Set up user authentication with message board and journal with fav river.

    Tuesday- Work on live updates with adding a river and messages displaying on the river page.

    Wednesday- Final UI and ReadME touch ups. Beautify or work on any bugs. 


    _____________________________________________________________________________________
                                         Notes
    Pulling river information every 2 hrs from 6am to 6pm = 6 pulls per river. Retrun only most popular rivers in OR WA.        

    Need to return information on a river searched.

    Need to create a loggin feature for user. 

    Need to create and be able to save a journal entry

    need to be able to incorporate google maps with aps to search rivers

https://waterdata.usgs.gov/or/nwis/current/?type=flow&group_key=county_cd
    

    scrapper how to website https://pusher.com/tutorials/web-scraper-node
    washington state river flow info  https://waterdata.usgs.gov/wa/nwis/current/?type=flow

        -Station Name 
        -Date and time
        -Gage height,feet
        -Dis-charge,ft3/s

    Oregon state river flow info https://waterdata.usgs.gov/or/nwis/current/?type=flow
        -Station Name 
        -Date and time
        -Gage height,feet
        -Dis-charge,ft3/s


    You can build a scrapper that will take the users river choice and ruturn that station id back to the href the scrapper will search for then scrap that site...
    ie; 
    const usersRiverSelection = props.userRiverSelection;
    const url = 'https://waterdata.usgs.gov/or/nwis/uv/?site_no=${usersRiverSelection}PARAmeter_cd=00065,00060';



Top 5 rivers for OR
*Clackamas upper

**put in's (Carnage)
 - Powerhouse
 - Hole in the wall
 - Fish creek
 - Toilet bowl
 ** Take Out's
 - Toilet Bowl
 - Moore Creek
 - Memoloose
 (Confidence  would be toilet bowl-memoloose)
 *Clackamas Lower
 **put in's ()
 - Mciver(upper)
 - Mciver(lower)
 - Feldheimer
 - Barton
 - Carver

 ** Take Out's
 - Mciver(lower)park
 - Feldheimer
 - Barton park
 - Carver park
 - Clackamette park

 *North Santiam

 ** Put in's
 - Big Cliff Dam
 - Pack Saddle
 - Mill City
 - Mehama

 ** Take Out's
 - Pack Saddle
 - Mill City
 - Mehama
 - Stayton

 * Mackenzie(Eugene)

 ** Put in's
 - Big Cliff Dam
 - Pack Saddle
 - Mill City
 - Mehama

 ** Take Out's
 - Pack Saddle
 - Mill City
 - Mehama
 - Stayton

 * Deshutes

 ** Put in's
 - Big Cliff Dam
 - Pack Saddle
 - Mill City
 - Mehama

 ** Take Out's
 - Pack Saddle
 - Mill City
 - Mehama
 - Stayton

 * John Day

 ** Put in's
 - Big Cliff Dam
 - Pack Saddle
 - Mill City
 - Mehama

 ** Take Out's
 - Pack Saddle
 - Mill City
 - Mehama
 - Stayton
 
 * Rouge River

 ** Put in's
 - Big Cliff Dam
 - Pack Saddle
 - Mill City
 - Mehama

 ** Take Out's
 - Pack Saddle
 - Mill City
 - Mehama
 - Stayton
 
 * Sandy

 ** Put in's
 - Big Cliff Dam
 - Pack Saddle
 - Mill City
 - Mehama

 ** Take Out's
 - Pack Saddle
 - Mill City
 - Mehama
 - Stayton
 


Top 5 rivers for WA
* White Salmon
* Wind
* Canyon Creek
* Washougal
* Clikatack
* East Fork of the Lewis
* Ohanapecosh (ohani)
* Upper Lewis (waterfall)
