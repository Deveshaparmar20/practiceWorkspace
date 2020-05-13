import React, { Component } from 'react'

class RegComp extends Component {
    render(props) {
        console.log('reg comp render')
        return (
            <div>
                Regular component {this.props.name}
            </div>
        )
    }
}

export default RegComp
