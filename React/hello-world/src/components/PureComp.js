import React, { PureComponent } from 'react'

class PureComp extends PureComponent {
    render(props) {
        console.log('pure comp render')
        return (
            <div>
                Pure Component {this.props.name}
            </div>
        )
    }
}

export default PureComp
