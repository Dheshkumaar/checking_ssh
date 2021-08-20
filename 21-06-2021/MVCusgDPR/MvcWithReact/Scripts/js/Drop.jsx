desert = [
    {
        value: 1,
        text: "Gulab Jamun"
    },
    {
        value: 2,
        text: "Basundi"
    },
    {
        value: 3,
        text: "Jalebi"
    },
    {
        value: 4,
        text: "Ras Malai"
    },
]
var items = desert.map(deserts => {
    return (
        <option>{deserts.text}</option>
    )
});
var Myapp = React.createClass({
    render: function () {
        return (
            <div>
                <select>{items}</select>
            </div>
        )
    }
});
React.render(<Myapp />, document.getElementById("dropdiv"));

