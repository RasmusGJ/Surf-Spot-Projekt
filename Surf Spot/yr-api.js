var request = new XMLHttpRequest()

// Open a new connection, using the GET request on the URL endpoint
request.open('GET', 'https://api.met.no/weatherapi/locationforecast/2.0/compact.json?lat=56.263920&lon=9.501785', true)

request.onload = function () {
  // Begin accessing JSON data here

    var data = JSON.parse(this.response)

    if (request.status >= 200 && request.status < 400) {
        data.forEach((things) => {
        console.log(things.air_pressure_at_sea_level)
        })
    } else {
        console.log('error')
    }
}

// Send request
request.send()
