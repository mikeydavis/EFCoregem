"use strict";

import React from 'react';
import assets from '../images';

class GearComponent extends React.Component {
    
    constructor() {
        super();
        this.state = {
            name: 'Mikie',
            id: '101'
        };
    }

    btnFGClicked(text){
        this.setState({
            name: text,
            text: this.refs.textBox.value
        });
    }

    render(){
        setTimeout(() => {
            this.setState({
                name: 'Nathan',
                id: '222'
            })
        }, 2000);

        const img = asssets("./images/mdx.png");

        return (
            <div className="NameGear">
                <h1>Heading gear for {this.props.name} </h1>
                <h2>Hello {this.state.name}</h2>
                <p>ID is : {this.state.id}</p>
                <img src={imp} />
                <input ref="textBox" type="text" />
                <button onClick={ (e) => {this.btnFGlicked('Hi Mike');} }>Change my name</button>
            </div>
        )
    }
}
ReactDOM.render(
    <GearComponent name="mikie" />, 
    document.getElementsByClassName('content')
);
