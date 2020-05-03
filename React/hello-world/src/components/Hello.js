import React from 'react'

const Hello=()=>{
    // return (
    //     <div className='dummyClass'>Hellow Dev</div>
    // )
    return React.createElement(
        'div',
        {id:'hello'},
        React.createElement('h1',null,'Devesha'))
}

export default Hello