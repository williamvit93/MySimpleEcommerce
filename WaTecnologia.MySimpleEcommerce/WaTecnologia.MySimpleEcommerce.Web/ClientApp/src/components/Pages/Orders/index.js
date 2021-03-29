import React, { Component } from 'react';

export class Orders extends Component {
    static displayName = Orders.name;

    constructor(props) {
        super(props);
        this.state = { orders: [], loading: true };
    }

    componentDidMount() {
        this.populateOrdersData();
    }

    static renderOrdersTable(orders) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Nome Completo</th>
                        <th>Data de Nascimento</th>
                        <th>CPF</th>
                    </tr>
                </thead>
                <tbody>
                    {orders.map(order =>
                        <tr key={order.id}>
                            <td>{order.fullName}</td>
                            <td>{new Date(order.birthDate).toLocaleDateString()}</td>
                            <td>{order.cpf}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Orders.renderOrdersTable(this.state.orders);

        return (
            <div>
                <h1 id="tabelLabel" >Orders</h1>
                {contents}
            </div>
        );
    }

    async populateOrdersData() {
        const response = await fetch('api/orders');
        const data = await response.json();
        this.setState({ orders: data, loading: false });
    }
}
