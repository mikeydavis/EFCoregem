//require('./lib');

import LIB1 from './lib';
//require('./lib');
import 'bootstrap/dist/css/bootstrap.min.css';
//import '../css/site.css';
import LIB6 from './es6lib';


let lib1 = new LIB1();

$("#fillthis").html(lib1.getDataBind());
$('#fillthiswithjquery').html('Filled by Jquery222!');

let lib6 = new LIB6();

$('#fillthiswithlib6').html(lib6.getData());