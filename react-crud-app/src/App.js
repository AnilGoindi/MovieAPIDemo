import logo from './logo.svg';
import './App.css';
import { BrowserRouter, Link, Route, Routes } from 'react-router-dom';
import { Container, Navbar, Nav } from 'react-bootstrap';

import Landing from './pages/landing';
import Actors from './pages/actors';

function App() {
  return (
    <Container>
      <BrowserRouter>
        <Navbar bg="dark" variant="dark">
          <Navbar.Brand as={Link} to="/">Movie World</Navbar.Brand>
          <Nav className="mr-auto">
            <Nav.Link as={Link} to="/">Movies</Nav.Link>
            <Nav.Link as={Link} to="/actors">Actors</Nav.Link>
          </Nav>
        </Navbar>        
        <Routes>
          <Route exact path="/" element={<Landing />} />
          <Route exact path="/actors" element={<Actors />} />
        </Routes>
      </BrowserRouter>
    </Container>
  );
}

export default App;
