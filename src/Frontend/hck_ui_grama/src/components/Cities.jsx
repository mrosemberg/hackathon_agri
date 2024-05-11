import { WiDayCloudy } from "react-icons/wi";

export default function Cities() {
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
        <p>Ciudades</p>
        <ul role="list" className="divide-y divide-gray-100">
          <li key={""} className="flex justify-between gap-x-6 py-5">
            <div className="flex min-w-0 gap-x-4">
              {/* <img
                className="h-12 w-12 flex-none rounded-full bg-gray-50"
                src={person.imageUrl}
                alt=""
              /> */}
              <div className="min-w-0 flex-auto">
                <p className="text-sm font-semibold leading-6 text-gray-900">
                  Ciudad 1
                </p>
                <p className="mt-1 truncate text-xs leading-5 text-gray-500">
                  Lluvia
                </p>
              </div>
            </div>
            <div className="hidden shrink-0 sm:flex sm:flex-col sm:items-end">
              <p className="text-sm leading-6 text-gray-900 text-white">
                <WiDayCloudy />
              </p>
              <div className="mt-1 flex items-center gap-x-1.5">
                <div className="flex-none rounded-full bg-emerald-500/20 p-1">
                  <div className="h-1.5 w-1.5 rounded-full bg-emerald-500" />
                </div>
                <p className="text-xs leading-5 text-gray-500">Lluvia</p>
              </div>
            </div>
          </li>
        </ul>
      </div>
    </>
  );
}
