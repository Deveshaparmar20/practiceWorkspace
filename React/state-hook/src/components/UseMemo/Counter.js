import React, { useState, useMemo } from 'react'

function Counter() {
    const [counterOne, setcounterOne] = useState(0)
    const [counterTwo, setcounterTwo] = useState(0)

    const incrementOne = () => {
        setcounterOne(counterOne + 1)
    }
    const incrementTwo = () => {
        setcounterTwo(counterTwo + 1)
    }

    const isEven = useMemo(() => {
        return counterOne % 2 == 0
    }, [counterOne])

    return (
        <div>
            <div>
                <button onClick={incrementOne}>Count one - {counterOne}</button>
                <span>{isEven ? 'Even' : 'Odd'}</span>
                <button onClick={incrementTwo}>Counter two - {counterTwo}</button>
            </div>
        </div>
    )
}

export default Counter
