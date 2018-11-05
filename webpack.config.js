var path = require('path');

module.exports = {
    mode:'development',
    entry: {
        main: './wwwroot/source/app.js'
    },
    output: {
       path: path.join(__dirname, '/wwwroot/dist'),
       filename: 'bundle.js'
    }
};