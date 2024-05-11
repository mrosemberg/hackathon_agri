function Search() {
  return (
    <>
      <form
        className=" w-96
        m-10
        rounded-2xl
       text-[#1A2421]
        backdrop-blur-xs 
        [ p-2 md:p-2 lg:p-3 ]
        [ bg-gradient-to-b from-white/60 to-white/30 ] 
        [ border-[1px] border-solid border-white border-opacity-30 ]
        [ shadow-black/70 shadow-2xl]"
      >
        <label
          for="search"
          className="form-label relative text-black/50 focus-within:text-[#333] mb-4"
        >
          <svg
            className="label-icon 
                  transition pointer-events-none
                  [ w-6 h-6 ] 
                  [ absolute top-1/2 left-3 ] 
                  [ transform -translate-y-1/2 ]"
            xmlns="http://www.w3.org/2000/svg"
            viewBox="0 0 24 24"
            fill="currentColor"
          >
            <path
              stroke="currentColor"
              stroke-linecap="round"
              stroke-linejoin="round"
              stroke-width="2"
              d="m19 19-4-4m0-7A7 7 0 1 1 1 8a7 7 0 0 1 14 0Z"
            />
          </svg>

          <input
            className="block w-full rounded-lg leading-none focus:outline-none placeholder-black/50 
                    [ transition-colors duration-200 ] 
                    [ py-1 pr-1 md:py-2 md:pr-2 lg:py-2 lg:pr-2 pl-12 ] 
                    [ bg-black/20 focus:bg-black/25 ] 
                    [ text-[#333] focus:text-black ]"
            type="password"
            name="password"
            id="password"
            placeholder="Buscar"
          />
        </label>
      </form>
    </>
  );
}

export default Search;
