import React from "react"
import { Children } from "react/cjs/react.production.min";
import useGithub from "../../hooks/github-hooks";
import Header from "../header";
import  * as S from "./styled"

const Layout = ({children}) => 
{
    const { githubState } = useGithub();
    return(
        <S.WrapperLayout>
            <Header/>
            {children}
        </S.WrapperLayout>
    );
        
    
}
export default Layout;