#include "pch.h"
#include <iostream>
#include <vector>
#include <algorithm>
#include <numeric>
#include <list>
#include <deque>
#include <unordered_map>
#include <unordered_set>
#include <string>

// using STR = std::string;

using namespace std;

int sum(const std::vector<int>& vec_, int i = 0)
{
   if (i >= vec_.size())
      return 0;
   return vec_[i] + sum(vec_, i + 1);
};

int count(const std::list<int>& list_, std::list<int>::const_iterator it = { }, bool inied_ = false)
{
   if (!inied_)
   {
      it = list_.begin();
      inied_ = true;
   }

   if (it == list_.end())
      return 0;
   return 1 + count(list_, std::next(it), inied_);
};

// Программа посторения графа и поиска по графу
unordered_map<string, unordered_set<string>> graph
{
   {"you", { "alice", "ЬоЬ", "claire" } },
   {"bob", {"anuj","peggy"}},
   {"claire", {"thom","jonny"}},
   {"alice", {"peggy"}},
   { "anuj", {} },
   { "peggy", {} },
   { "thom", {} },
   { "jonny", {} }
};

bool senior_pomidor(string name)
{
   return (name.size() > 3);
}


string adder(string name)
{
   unordered_set<string> example;
   deque<string> dec;
   dec.push_back(name);
   while (!dec.empty())
   {
      string persona = dec.front();
      dec.pop_front();
      if (example.find(persona) == example.end())
      {
         if (senior_pomidor(persona))
         {
            std::cout << persona << " is programmer pomidor" << endl;
            return persona;
         }
         else
         {
            for(const string& friends: graph[persona])
               dec.push_back(friends);
            example.insert(persona);
         }
      }
   }
   std::cout << "We have not senior_pomidor" << endl;
   return "We have not senior_pomidor";
}
// end Программа посторения графа и поиска по графу

int main()
{
   std::vector<int> vec_ = { 4, 5, 6 };
   std::cout << sum(vec_) << endl;
   //std::cout << std::accumulate(vec_.begin(), vec_.end(), 0, std::plus<>());
   std::list<int> list_ = { 7, 16, 40, 47 };
   std::cout << count(list_) << endl;
   adder("bob");
   return 0;
}

