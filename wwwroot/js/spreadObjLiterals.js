let person = {
    name : "Mike",
    surname : "Davis",
    age: 45
}

let clone = {...person};
const runners = ["Tom","Paul","Mark","Luke" ];
const [first, second, ...losers] = runners;





console.log(clone);
console.log(...losers);