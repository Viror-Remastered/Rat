#ifndef CPPRAT_DEBUG_HPP
#define CPPRAT_DEBUG_HPP

#include "chunk.hpp"

void disassembleChunk(Chunk* chunk, const char* name);
int disassembleInstruction(Chunk* chunk, int offset);

#endif