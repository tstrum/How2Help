import { Container, CssBaseline } from '@mui/material'
import './App.css'
import Header from './Header'
import { Outlet } from 'react-router-dom';

function App() {
  //const location = useLocation();
  //const [loading, setLoading] = useState(true);

  return (
    <>
      <CssBaseline />
      <Header />
      <Container>
        <Outlet />
      </Container>
    </>
    
  )
}

export default App
