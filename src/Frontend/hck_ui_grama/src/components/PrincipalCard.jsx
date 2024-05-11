import { AiFillHome } from "react-icons/ai";
import { WiCelsius } from "react-icons/wi";
import { WiCloud } from "react-icons/wi";
import { WiDayCloudyGusts } from "react-icons/wi";
import { WiDayRain } from "react-icons/wi";

function PrincipalCard() {
  return (
    <>
      <div
        className="w-96
        m-10
        rounded-2xl
       text-[#1A2421]
        backdrop-blur-xs 
        [ p-2 md:p-2 lg:p-3 ]
        [ bg-gradient-to-b from-white/20 to-white/30 ] 
        [ border-[1px] border-solid border-white border-opacity-30 ]
        [ shadow-black/70 shadow-2xl]"
      >
        <p>
          {" "}
          <span>
            <AiFillHome /> - {Date.now()}
          </span>
        </p>
        <p>11 de mayo, 2024</p>
        <h1>
          26 <WiCelsius />
        </h1>
        <h2>Estado del Tiempo</h2>
        <p>OPTIMO</p>
        <p>
          <span>
            <WiDayCloudyGusts /> Viento 10KM/h
          </span>
          -
          <span>
            <WiCloud /> Humedad 54 %
          </span>
          -
          <span>
            <WiDayRain /> Precipitaciones 0.2 %
          </span>
        </p>
      </div>
    </>
  );
}

export default PrincipalCard;
