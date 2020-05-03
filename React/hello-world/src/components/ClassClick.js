import React, { Component } from 'react'

class ClassClick extends Component {
    clickHandler(){
        console.log("yes")
    }
    render() {
        return (
            <div>
                <button onClick={this.clickHandler}>click Me</button>
            </div>
        )
    }
}

export default ClassClick
