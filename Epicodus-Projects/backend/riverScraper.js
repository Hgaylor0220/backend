// @TODO: Pass actual value here.
var siteid = 14301500;

var m = new Date();
// @TODO: Do non UTC version for this, remove -1 on date.
const date = m.getUTCFullYear() + "/" + (m.getUTCMonth() + 1) + "/" + (m.getUTCDate() - 1);

console.log(date);

const rp = require('request-promise');
const url = 'https://waterdata.usgs.gov/nwis/uv?cb_00060=on&cb_00065=on&format=rdb&site_no=' + siteid + '&begin_date=' + date;

rp(url)
    .then(function (data) {
        // TSV file has blank line at end, we always need 2nd to last line.
        values_split = data.split('\n');
        last_reading_value = values_split[values_split.length - 2];
        reading_values_split = last_reading_value.split('\t');

        // Get relevant values.
        reading_time = reading_values_split[2]
        reading_cfs = reading_values_split[4]
        reading_height = reading_values_split[6]

        console.log([
            reading_time,
            reading_cfs,
            reading_height,
        ]);
    })
    .catch(function (err) {
        //handle error
    });
