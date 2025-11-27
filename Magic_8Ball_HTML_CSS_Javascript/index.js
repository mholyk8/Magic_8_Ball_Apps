//an array of predictions
const predictions = ["It is certain",
    "It is decidedly so",
    "Without a doubt",
    "Yes definitely",
    "You may rely on it",
    "As I see it, yes",
    "Most likely",
    "Outlook good",
    "Yes",
    "Signs point to yes ",
    "Don't count on it",
    "My reply is no",
    "My sources say no",
    "Outlook not so good",
    "Very doubtful ",
    "Reply hazy, try again",
    "Ask again later",
    "Better not tell you now",
    "Cannot predict now",
    "Concentrate and ask again "];

//code to be ready to run onload of the webpage
$(document).ready(function(){
    //call the Predict function when the button is clicked
    $("#action").click(function(){Predict()});
    //call the Revert function when the textarea is clicked
    $("#query").click(function(){Revert()});
})

//a function to predict the future
function Predict(){
    //only respond if the textarea element received input
    if($("#query").val().length > 0){
        //randomly choose an index of the predictions array 
        const rndIndex = Math.floor(Math.random() * predictions.length);
        //obtain the content of the chosen index of the predictions array
        const rndPrediction = predictions[rndIndex];
        //change the the src attribute of the image element
        $("#ball").attr("src", "./images/8BallBack.png");
        //fill the innerhtml of the <p> element with the prediction
        $("#msg").html(rndPrediction);
        //clear the textarea element of the user's question
        $("#query").val("")
    }
}

//a function to revert the page to before the prediction
function Revert(){
    //remove the innerhtml of the <p> element
    $("#msg").html("");
    //change the the src attribute of the image element
    $("#ball").attr("src", "images/8ball.png");
}