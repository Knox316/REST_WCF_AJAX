google.maps.event.addDomListener(window, 'load', intilize);
    function intilize() {
        var autocomplete = new google.maps.places.Autocomplete(document.getElementById("txtautocomplete"));

        google.maps.event.addListener(autocomplete, 'place_changed', function () {

        var place = autocomplete.getPlace();
        var location = "Address: " + place.formatted_address + "<br/>";
          location += "Latitude: " + place.geometry.location.lat() + "<br/>";
          location += "Longitude: " + place.geometry.location.lng();
        document.getElementById('lblresult').innerHTML = location
        var x = place.geometry.location.lat();
        var y = place.geometry.locationlng();
        document.getElementsByName('cx').innerHTML = x
        document.getElementsByName('cy').innerHTML = y
        });
    };