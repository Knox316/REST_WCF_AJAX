function inicialize(){
    var myLatlng = new google.maps.Latlng(37.7799376,-122.4097525);
    var mapOptions = {
        zoom:12,
        center: myLatlng,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    }
    var map = new google.maps.Map(document.getElementbyId('map-canvas'), mapOptions
}