import React, { Component } from 'react'
class LifeCycleB extends Component {
    constructor(props) {
        super(props)
    
        this.state = {
             name:'Devesha'
        }
        console.log('LifeCycleB Constructor')
    }
    static getDerivedStateFromProps(props,state){
        console.log('LifeCycleB getDerivedStateFromProps')
        return null
    }
    componentDidMount(){
        console.log('LifeCycleB component did mount')
    }
    shouldComponentUpdate(){
        console.log('LifecycleB should component update')
        return true
    }
    getSnapshotBeforeUpdate(){
        console.log('LifecycleB getSnapshotBeforeUpdate')
        return null
    }
    componentDidUpdate(){
        console.log('LifecycleB componentDidUpdate')
    }
    render() {
        console.log('LifeCycleB render')
        return (
            <div>
                LifeCycleB
            </div>
        )
    }
}

export default LifeCycleB