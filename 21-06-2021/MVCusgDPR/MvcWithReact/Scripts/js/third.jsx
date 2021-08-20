class DDl extends React.Component {
    desert = [
        {
            value:1,
            text :"Gulab Jamun"
        },
        {
            value:2,
            text :"Basundi"
        },
        {
            value:3,
            text :"Jalebi"
        },
        {
            value:4,
            text :"Ras Malai"
        },
    ]
    render() {
        return (
            <div>
                <h1>DROPDOWN LIST USING REACT</h1>
                <select>
                    <option>--Select An Option --</option>
                    {
                        this.desert.map(displaydesert =>
                            <option title={displaydesert.value}>{displaydesert.text}</option>)
                    }
                </select>
            </div>        
            )
    }
}

React.render(<DDl />, document.getElementById("list"));