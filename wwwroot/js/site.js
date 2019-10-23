$( document ).ready(function() {
  var pet = {
    fullness: $("#fullness-data").data("fullness"),
    happiness: $("#happiness-data").data("happiness"),
    meals: $("#meals-data").data("meals"),
    energy: $("#energy-data").data("energy"),
    alive: false,
    message: "Hatch your egg!"
  }

  const updateStats = (petObj) => {
    $.ajax({
      url: setData(petObj)
    }).done(()=>{
      $("#fullness-data").append(petObj.fullness);
      $("#happiness-data").append(petObj.happiness)
      $("#meals-data").append(petObj.meals)
      $("#energy-data").append(petObj.energy)
      $("#message-container").append(petObj.message)
    })
  }

  const setData = (petObj) => {
    $("#fullness-data").empty();
    $("#happiness-data").empty();
    $("#meals-data").empty();
    $("#energy-data").empty();
    
    $("#fullness-data").data("fullness", petObj.fullness);
    $("#happiness-data").data("happiness", petObj.happiness);
    $("#meals-data").data("meals", petObj.meals);
    $("#energy-data").data("energy", petObj.energy);

    pet = petObj;
  }



  updateStats(pet);

  $("#dojodachi-egg").on("click", ()=>{
    $.ajax({
      type: "GET",
      url: "../../GetStats",
      contentType: "application/json; charset=utf-8",
      dataType: "json"
    }).done((data)=>{
      $("#dojodachi-container").empty();
      $("#message-container").empty();
      $("#dojodachi-container").append(()=>{
        return '<img src="https://vignette.wikia.nocookie.net/tamagotchi/images/2/2b/Kuchipatchi_anime.PNG/revision/latest/scale-to-width-down/350?cb=20110918052545" alt="green">';
      })
      // $("#message-container").append(()=>{
      //   return "<p>Say hello to you dojodachi!</p>";
      // })
      pet = data;
      console.log(data);
      updateStats(pet);
    })
  })



  $("#feed-button").on("click", ()=>{
    $("#message-container").empty();

    $.ajax({
      url: "../../feed",
      method: "PUT",
      data: JSON.stringify(pet)
    }).done((result)=>{
      console.log(result);
      pet = result;
      updateStats(result);
    })

  })
});