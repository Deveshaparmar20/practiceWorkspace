import React, { Component } from 'react'
import LifeCycleB from './LifeCycleB'
class LifeCycleA extends Component {
    constructor(props) {
        super(props)
    
        this.state = {
             name:'Devesha'
        }
        console.log('LifeCycleA Constructor')
    }
    static getDerivedStateFromProps(props,state){
        console.log('LifecycleA getDerivedStateFromProps')
        return null
    }
    componentDidMount(){
        console.log('LifecycleA component did mount')
    }
    shouldComponentUpdate(){
        console.log('LifecycleA should component update')
        return true
    }
    getSnapshotBeforeUpdate(){
        console.log('LifecycleA getSnapshotBeforeUpdate')
        return null
    }
    componentDidUpdate(){
        console.log('LifecycleB componentDidUpdate')
    }
    changeState=()=>{
        this.setState({
            name:'Dev'
        })
    }
    render() {
        console.log('LifecycleA render')
        return (
            <div>
                <div>LifeCycleA</div>
                <LifeCycleB/>
                <button onClick={this.changeState}>Change State</button>
            </div>
        ) 
    }
}

export default LifeCycleA