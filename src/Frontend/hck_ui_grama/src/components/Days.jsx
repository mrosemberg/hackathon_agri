import { WiDayCloudy } from "react-icons/wi";
import { WiDayHail } from "react-icons/wi";
import { WiDayLightning } from "react-icons/wi";

function Days() {
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
        <WiDayCloudy />
      </div>
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
        <WiDayHail />
      </div>
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
        <WiDayLightning />
      </div>
    </>
  );
}

export default Days;
