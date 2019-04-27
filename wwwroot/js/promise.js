

fetch('http://whm.midax.co.uk/api/blogsdata').then( res => {
    return res.json();
}).then(res => {
    //print data
    console.log(res); 
}).catch(err => {
    console.log(err);
})