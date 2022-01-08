import React from 'react';
import Layout from './components/layout';
import NoSearch from './components/no-search';
import Profile from './components/profile'
import Repositories from './components/repositories';
import { ResetCSS } from './global/resetCSS';
import useGithub from './hooks/github-hooks';
import GithubProvider from './providers/github-provider';

const App = () => {
  const {githubState} = useGithub();
  return (
    
    <Layout>
      {githubState.hasUser ?  <>
       {githubState.loading ? (
          <p>Loading</p> 
          ) : (
          <>
            <Profile />
            <Repositories/>
            </>
        )}
      </>: <NoSearch/>}
    </Layout>
  );
};

export default App;