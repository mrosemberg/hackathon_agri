import Search from "./components/Search";
import PrincipalCard from "./components/PrincipalCard";
import Cities from "./components/Cities";

export default function App() {
  return (
    <>
      <div className="bg-[url('./assets/background/fondo_4.jpg')] bg-cover bg-center h-screen bg-no-repeat">
        <div className="flex flex-row ">
          <Search />
        </div>
        <div className=" justify-center">
          <PrincipalCard />
        </div>
        <div>
          <Cities />
        </div>
      </div>
    </>
  );
}
