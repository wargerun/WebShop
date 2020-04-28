/*
    
*/

if (typeof ymaps === 'undefined') {
    let divBlockIdMap = document.getElementById('map');
    divBlockIdMap.innerHTML = "тут должна была быть карта =(";
} else {
    ymaps.ready(init);
}

function init() {
    let divBlockIdMap = document.getElementById('map');

    var myMap = new ymaps.Map(divBlockIdMap, {
        center: [51.035883, 59.879702],
        zoom: 18
    });

    myMap.geoObjects.add(new ymaps.Placemark(myMap.getCenter(), {
        balloonContent: '462781, г Ясный Оренбургской области, ул. Свердлова д. 5Б',
        iconCaption: 'АвтоМиг'
    }, {
        preset: 'islands#greenDotIconWithCaption'
    }));
}