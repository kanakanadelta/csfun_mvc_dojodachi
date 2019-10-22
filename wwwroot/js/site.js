var pet = {
  fullness: 0,
  happiness: 0,
  meals: 0,
  energy: 0,
  alive: false
}

const updateStats = () => {
  $("#fullness-data").empty();
  $("#happiness-data").empty();
  $("#meals-data").empty();
  $("#energy-data").empty();
  
  $("#fullness-data").append(pet.fullness);
  $("#happiness-data").append(pet.happiness)
  $("#meals-data").append(pet.meals)
  $("#energy-data").append(pet.energy)

}


$( document ).ready(function() {
  updateStats();

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
      $("#message-container").append(()=>{
        return "<p>Say hello to you dojodachi!</p>";
      })
      pet = data;
      // console.log(data);
      updateStats();
    })
  })



  $("#feed-button").on("click", ()=>{
    $("#message-container").empty();

    // $.ajax({
    //   url: "/Home/feed",
    //   method: "PUT",
    //   data: {

    //   }
    // })

  })
});