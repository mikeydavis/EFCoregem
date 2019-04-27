var path = require('path');
const webpack = require('webpack');

module.exports = {
    mode:'development',
    entry: {
        main: './wwwroot/source/app.js'
    },
    output: {
       path: path.join(__dirname, '/wwwroot/dist'),
       filename: 'bundle.js',
       publicPath:'/dist/'
    },
    plugins: [
        new webpack.ProvidePlugin({
                   $: 'jquery',
              jQuery: 'jquery',
     'window.jQuery': 'jquery',
     Popper: ['popper.js', 'default']
                         })
        ],
        module:{
            rules:[ 
                {test: /\.css$/, use: [{ loader: "css-loader" }, { loader: "css-loader" }]},
                {test: /\.js?$/, 
                use: { loader: 'babel-loader', options: { presets: 
                             ['@babel/preset-env'] } } },
                 ]
        }
};