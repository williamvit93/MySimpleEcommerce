import React, { Component } from 'react';

export class Products extends Component {
    static displayName = Products.name;

    constructor(props) {
        super(props);
        this.state = { products: [], loading: true };
    }

    componentDidMount() {
        this.populateProductsData();
    }

    static renderProductsTable(products) {
        return (
            <div className="container" style={{ marginBottom: '30px' }}>
                <div className="row">
                    <div className="col col-sm-3">
                        <div className="card">
                            <div className="card-header text-center">
                                <img
                                    style={{ maxWidth: '130px' }}
                                    className="card-img-top"
                                    src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEhRESsmk3gZXHWC6MzYWgYrA69Do796a7fg&usqp=CAU"
                                    alt="Card image cap"
                                />

                            </div>
                            <div className="card-body">
                                <h5 className="card-title">R$ 999,99</h5>
                                <p className="card-text">Smartphone XYZ 2.0</p>
                            </div>

                            <div className="card-footer text-center">
                                <button href="#" className="btn btn-danger btn-lg" title="Comprar">
                                    <i className="fa fa-shopping-cart" style={{ marginRight: '5px' }} />
                                        Comprar
                                    </button>
                            </div>
                        </div>
                    </div>
                    <div className="col col-sm-3">
                        <div className="card">
                            <div className="card-header text-center">
                                <img
                                    style={{ maxWidth: '130px' }}
                                    className="card-img-top"
                                    src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEhRESsmk3gZXHWC6MzYWgYrA69Do796a7fg&usqp=CAU"
                                    alt="Card image cap"
                                />

                            </div>
                            <div className="card-body">
                                <h5 className="card-title">R$ 999,99</h5>
                                <p className="card-text">Smartphone XYZ 2.0</p>
                            </div>

                            <div className="card-footer text-center">
                                <button href="#" className="btn btn-danger btn-lg" title="Comprar">
                                    <i className="fa fa-shopping-cart" style={{ marginRight: '5px' }} />
                                        Comprar
                                    </button>
                            </div>
                        </div>
                    </div>
                    <div className="col col-sm-3">
                        <div className="card">
                            <div className="card-header text-center">
                                <img
                                    style={{ maxWidth: '130px' }}
                                    className="card-img-top"
                                    src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEhRESsmk3gZXHWC6MzYWgYrA69Do796a7fg&usqp=CAU"
                                    alt="Card image cap"
                                />

                            </div>
                            <div className="card-body">
                                <h5 className="card-title">R$ 999,99</h5>
                                <p className="card-text">Smartphone XYZ 2.0</p>
                            </div>

                            <div className="card-footer text-center">
                                <button href="#" className="btn btn-danger btn-lg" title="Comprar">
                                    <i className="fa fa-shopping-cart" style={{ marginRight: '5px' }} />
                                        Comprar
                                    </button>
                            </div>
                        </div>
                    </div>
                    <div className="col col-sm-3">
                        <div className="card">
                            <div className="card-header text-center">
                                <img
                                    style={{ maxWidth: '130px' }}
                                    className="card-img-top"
                                    src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEhRESsmk3gZXHWC6MzYWgYrA69Do796a7fg&usqp=CAU"
                                    alt="Card image cap"
                                />

                            </div>
                            <div className="card-body">
                                <h5 className="card-title">R$ 999,99</h5>
                                <p className="card-text">Smartphone XYZ 2.0</p>
                            </div>

                            <div className="card-footer text-center">
                                <button href="#" className="btn btn-danger btn-lg" title="Comprar">
                                    <i className="fa fa-shopping-cart" style={{ marginRight: '5px' }} />
                                        Comprar
                                    </button>
                            </div>
                        </div>
                    </div>
                    <div className="col col-sm-3">
                        <div className="card">
                            <div className="card-header text-center">
                                <img
                                    style={{ maxWidth: '130px' }}
                                    className="card-img-top"
                                    src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEhRESsmk3gZXHWC6MzYWgYrA69Do796a7fg&usqp=CAU"
                                    alt="Card image cap"
                                />

                            </div>
                            <div className="card-body">
                                <h5 className="card-title">R$ 999,99</h5>
                                <p className="card-text">Smartphone XYZ 2.0</p>
                            </div>

                            <div className="card-footer text-center">
                                <button href="#" className="btn btn-danger btn-lg" title="Comprar">
                                    <i className="fa fa-shopping-cart" style={{ marginRight: '5px' }} />
                                        Comprar
                                    </button>
                            </div>
                        </div>
                    </div>
                    <div className="col col-sm-3">
                        <div className="card">
                            <div className="card-header text-center">
                                <img
                                    style={{ maxWidth: '130px' }}
                                    className="card-img-top"
                                    src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEhRESsmk3gZXHWC6MzYWgYrA69Do796a7fg&usqp=CAU"
                                    alt="Card image cap"
                                />

                            </div>
                            <div className="card-body">
                                <h5 className="card-title">R$ 999,99</h5>
                                <p className="card-text">Smartphone XYZ 2.0</p>
                            </div>

                            <div className="card-footer text-center">
                                <button href="#" className="btn btn-danger btn-lg" title="Comprar">
                                    <i className="fa fa-shopping-cart" style={{ marginRight: '5px' }} />
                                        Comprar
                                    </button>
                            </div>
                        </div>
                    </div>
                    <div className="col col-sm-3">
                        <div className="card">
                            <div className="card-header text-center">
                                <img
                                    style={{ maxWidth: '130px' }}
                                    className="card-img-top"
                                    src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEhRESsmk3gZXHWC6MzYWgYrA69Do796a7fg&usqp=CAU"
                                    alt="Card image cap"
                                />

                            </div>
                            <div className="card-body">
                                <h5 className="card-title">R$ 999,99</h5>
                                <p className="card-text">Smartphone XYZ 2.0</p>
                            </div>

                            <div className="card-footer text-center">
                                <button href="#" className="btn btn-danger btn-lg" title="Comprar">
                                    <i className="fa fa-shopping-cart" style={{ marginRight: '5px' }} />
                                        Comprar
                                    </button>
                            </div>
                        </div>
                    </div>
                    <div className="col col-sm-3">
                        <div className="card">
                            <div className="card-header text-center">
                                <img
                                    style={{ maxWidth: '130px' }}
                                    className="card-img-top"
                                    src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEhRESsmk3gZXHWC6MzYWgYrA69Do796a7fg&usqp=CAU"
                                    alt="Card image cap"
                                />

                            </div>
                            <div className="card-body">
                                <h5 className="card-title">R$ 999,99</h5>
                                <p className="card-text">Smartphone XYZ 2.0</p>
                            </div>

                            <div className="card-footer text-center">
                                <button href="#" className="btn btn-danger btn-lg" title="Comprar">
                                    <i className="fa fa-shopping-cart" style={{ marginRight: '5px' }} />
                                        Comprar
                                    </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Products.renderProductsTable(this.state.products);

        return (
            <div>
                {contents}
            </div>
        );
    }

    async populateProductsData() {
        const response = await fetch('api/products');
        const data = await response.json();
        this.setState({ products: data, loading: false });
    }
}
