const race = '100 Metres';
const runners = ["Usain Bolt", "Justin Gatlin", "Asafa Powell"];

const winners = runners.map((runner,i) => ({name: runner, race, place: i + 1}))

console.log(winners)

//this and the arrow key
const box = document.querySelect(".box");

box.addElementListener("click", function(){
    this.classList.toggle("opening");
    setTimeout( () => {
        this.classList.toggle("open");
    });
})