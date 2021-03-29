import React, { Component } from 'react';

export class Customers extends Component {
    static displayName = Customers.name;

    constructor(props) {
        super(props);
        this.state = { customers: [], loading: true };
    }

    componentDidMount() {
        this.populateCustomersData();
    }

    static renderCustomersTable(customers) {
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
                    {customers.map(customer =>
                        <tr key={customer.id}>
                            <td>{customer.fullName}</td>
                            <td>{new Date(customer.birthDate).toLocaleDateString()}</td>
                            <td>{customer.cpf}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Customers.renderCustomersTable(this.state.customers);

        return (
            <div>
                <h1 id="tabelLabel" >Customers</h1>
                {contents}
            </div>
        );
    }

    async populateCustomersData() {
        const response = await fetch('api/customers');
        const data = await response.json();
        this.setState({ customers: data, loading: false });
    }
}
