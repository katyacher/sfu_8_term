package com.example.demo.repository;

import com.example.demo.model.TextEntry;
import org.springframework.data.mongodb.repository.MongoRepository;

public interface TextEntryRepository extends MongoRepository<TextEntry, String> {
}
